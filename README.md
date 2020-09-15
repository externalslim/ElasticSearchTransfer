# ElasticSearchTransfer

Before this project, main call was data transfering between older version ES to newer version / newer version ES to older version ES.
It works for version free actually. Lucene's index mechanism changed on 5.x version, just because of this, you have to merge your ES data on 5.x
which is older version's. Then you can use >5.x version. 

With this project, just write your 'from' ES machine configuration (IP, PORT for ES) and also 'to'. Then just merge them.

You can ping your computers beforer the merge process.


ES docker compose example 

version: '2.2'
services:
  es01:
    image: elasticsearch:7.7.0
    container_name: elasticsearch
    environment:
      - node.name=es01
      - cluster.name=es-docker-cluster
      - discovery.seed_hosts=es02,es03
      - cluster.initial_master_nodes=es01
      - bootstrap.memory_lock=true
      - "ES_JAVA_OPTS=-Xms512m -Xmx512m"
    ulimits:
      memlock:
        soft: -1
        hard: -1
    volumes:
      - elasticdata:/usr/share/elasticsearch/data
    ports:
      - 9200:9200
    networks:
      - elastic

volumes:
  elasticdata:
    driver: local

networks:
  elastic:
    driver: bridge
