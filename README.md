# ElasticSearchTransfer

Before this project, main call was data transfering between older version ES to newer version / newer version ES to older version ES.
It works for version free actually. Lucene's index mechanism changed on 5.x version, just because of this, you have to merge your ES data on 5.x
which is older version's. Then you can use >5.x version. 

With this project, just write your 'from' ES machine configuration (IP, PORT for ES) and also 'to'. Then just merge them.

You can ping your computers beforer the merge process.
