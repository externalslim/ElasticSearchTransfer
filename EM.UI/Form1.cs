using EM.ElasticGetter.ToLayer;
using EM.ElasticPusher.FromLayer;
using EM.Helper.Models;
using EM.Helper.RestCaller;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace EM.UI
{
    public partial class ElasticSearchMerge : MetroForm
    {
        public ElasticSearchMerge()
        {
            InitializeComponent();
        }

        private void toPingTest_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ip_toTextBox.Text.Trim()) && !String.IsNullOrEmpty(port_toTextBox.Text.Trim()))
            {
                try
                {
                    using (var client = new TcpClient(ip_toTextBox.Text, Convert.ToInt32(port_toTextBox.Text)))
                    {
                        if (client.Connected)
                        {
                            MessageBox.Show("Ping Succeed. " + ip_toTextBox.Text + ":" + port_toTextBox.Text + "  is available!");
                            toPingResult.Text = "Succeed";
                        }
                        else
                        {
                            MessageBox.Show("Something goes wrong!");
                            toPingResult.Text = "Failed";

                        }
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Error pinging host:'" + ip_toTextBox.Text + ":" + port_toTextBox.Text + "'");
                }
            }
        }

        private void fromPingTest_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ip_fromTextBox.Text.Trim()) && !String.IsNullOrEmpty(port_fromTextBox.Text.Trim()))
            {
                try
                {
                    using (var client = new TcpClient(ip_fromTextBox.Text, Convert.ToInt32(port_fromTextBox.Text)))
                    {
                        if (client.Connected)
                        {
                            MessageBox.Show("Ping Succeed. " + ip_fromTextBox.Text + ":" + port_fromTextBox.Text + "  is available!");
                            fromPingResult.Text = "Succeed";
                        }
                        else
                        {
                            MessageBox.Show("Something goes wrong!");
                            fromPingResult.Text = "Failed";
                        }
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Error pinging host:'" + ip_fromTextBox.Text + ":" + port_fromTextBox.Text + "'");
                }
            }
        }

        private void startMergeProcess_Click(object sender, EventArgs e)
        {
            if (
                !String.IsNullOrEmpty(ip_toTextBox.Text.Trim()) && !String.IsNullOrEmpty(port_toTextBox.Text.Trim()) &&
                !String.IsNullOrEmpty(ip_fromTextBox.Text.Trim()) && !String.IsNullOrEmpty(port_fromTextBox.Text.Trim())
               )
            {
                var toUrl = "http://" + ip_toTextBox.Text + ":" + port_toTextBox.Text;
                var fromUrl = "http://" + ip_fromTextBox.Text + ":" + port_fromTextBox.Text;

                MakeCallToElastic.Url = toUrl;
                MakeCallToElastic.IndiceParameter = "/_cat/indices?format=json&pretty=true";
                var toIndiceList = MakeCallToElastic.GetIndiceList();
                progressLabel.Text = "Fetch indices ...";
                progressLabel.Visible = true;
                if (toIndiceList.Count > 0)
                {
                    var elasticSearchDataModelWithIndexList = new List<ElasticSearchDataModelWithIndex>();
                    var perProcess = ProgressBarProcess(toIndiceList.Count);
                    mergeProgressBar.Visible = true;
                    foreach (var item in toIndiceList)
                    {
                        mergeProgressBar.Value += perProcess;
                        var result = MakeCallToElastic.GetDataModelWithIndiceName(item.index);
                        elasticSearchDataModelWithIndexList.Add(new ElasticSearchDataModelWithIndex
                        {
                            index = item.index,
                            ElasticSearchDataModels = result
                        });
                    }
                    mergeProgressBar.Value = 100;
                    Thread.Sleep(1000);
                    mergeProgressBar.Value = 0;
                    mergeProgressBar.Visible = false;
                    
                    progressLabel.Text = "Merging ...";

                    foreach (var item in elasticSearchDataModelWithIndexList)
                    {
                        mergeProgressBar.Value += 100 / elasticSearchDataModelWithIndexList.Count;
                        var perProcesSearchDataModelWithIndex = ProgressBarProcess(item.ElasticSearchDataModels.Count);
                        mergeProgressBar.Visible = true;

                        foreach (var sub in item.ElasticSearchDataModels)
                        {
                            mergeProgressBar.Value += perProcesSearchDataModelWithIndex;
                            for (int i = 0; i < sub.hits.hits.Count ; i++)
                            {
                                var source = JsonConvert.SerializeObject(sub.hits.hits[i]._source);
                                var _id = sub.hits.hits[i]._id;
                                var _type = sub.hits.hits[i]._type;

                                MakeCallFromElastic.Url = fromUrl;
                                MakeCallFromElastic.IndiceParameter = "/" + item.index + "/" + _type + "/" + _id;
                                MakeCallFromElastic.Data = source;
                                MakeCallFromElastic.CreateNewIndex();
                            }
                        }
                    }

                    mergeProgressBar.Value = 0;
                    mergeProgressBar.Visible = false;
                    progressLabel.Visible = false;
                    progressLabel.Text = "";
                    MessageBox.Show("Merge completed!");
                }
            }
        }

        private int ProgressBarProcess(int totalList)
        {
            return 100 / totalList;
        }
    }
}
