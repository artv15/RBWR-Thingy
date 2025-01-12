# RBWR Thingy
An unfinished calculator that does two things as of now

## MWe to APR conversion
Can convert MWe demand and plant usage to a more or less approximate APR target.\
As far as I have tested, there is about 5 MWe difference, although note that I tested this only in unit 1, classic type.\
Actual value may be wrong if:
- If you have a broken/disabled preheater
- You have not updated plant usage
- Not supplying reactor with enough feedwater (steam outflow seems to be higher if you supply it with less feedwater)
Will also show an approximate feedwater flow, which should also be treated as a rough approximation (±30 kg/s).
## Pump repairs on high load
Allows to calculate whether you can run without a pump without changing your load.\
Pretty precise I would say, at least it worked for unit 1 when I was testing it on a private server.

## Credits
[This guide](https://docs.google.com/document/d/1Irwh4lIR1y15hKauZ3XupzsZ79sPYgwSfMnnWt8aulc/edit) by Avalakaba (@kopa_tel_oflain) for MCC formula\
[This website](https://nxrvi.github.io/rbwrmultitoolweb/) from which I ~~shamelessly stole~~ adapted MWe to APR formula.

## Downloads
Check releases for precompiled app or build it yourself from source.\
You need .Net Framework v4.8.1 to compile it.

## Disclaimer
i'm not responsible if I get your reactor explodet, sowwy
