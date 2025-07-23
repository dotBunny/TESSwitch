# TESSwitch

Tested against TES [HKS1601-EB23-CABK](https://www.tesmart.com/products/hks1601-eb23), following their stated [protocols](https://support.tesmart.com/hc/en-us/article_attachments/10269851662361).
> The switching commands are shared across numerous products, so this should work for all sorts of different TES KVMs with network control.


## Arguments

| Short | Long | Description | Required | Default |
| --- | --- | --- | --- | --- |
| -p | --port |  The TES connection port. | No | 5000 |
| -i | --ip | The TES internet protocol. | No | 192.168.1.10 |
| -c | --channel | The channel to switch to (0-16) | *Yes* | n/a |
