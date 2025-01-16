# RBWR Thingy
A multitool that does three things as of now

## MWe to APR conversion
Can convert MWe demand and plant usage to a more or less approximate APR target.\
As far as I have tested, there is about 0.1 MWe difference when within 20-100% APR range, and 1 MWe difference outside this range. Only applies if you are using auto.\
Actual value may be wrong if:
- Steam pressure is not at 7.1 MPa
- You have a broken/disabled preheater
- You have not updated plant usage
- Sealing is not at 0.25 bar (unit 2 only)

Will also show an approximate feedwater flow, which should be treated as a rough approximation (±30 kg/s).

*On the note of formulas, quadratic works well on high gen loads, and is inprecise on low ones. Linear is the opposite, good on low, bad on high. Auto just switches them at the point of convergence (around 290 MWe, but it may change if I update the formulas) with smoothing, and I highly recommend to just leave it on auto.*
## Pump repairs on high load
Allows to calculate whether you can run without a pump without changing your load.\
Pretty precise I would say, at least it worked for unit 1 when I was testing it on a private server.
It may be easier to do in unit 2, since pump lag is actually helpful this time.
## Repairs flagger
Useful if you get disconnected from the game from time to time, or just don't like in-game clipboard.

## Credits
[This guide](https://docs.google.com/document/d/1Irwh4lIR1y15hKauZ3XupzsZ79sPYgwSfMnnWt8aulc/edit) by Avalakaba (@kopa_tel_oflain) for the MCC formula\
[This website](https://nxrvi.github.io/rbwrmultitoolweb/) by [Nxrvi](https://github.com/Nxrvi) for the APR to Feedwater flow formula.\
*MWe to APR formula was also initially taken from it, but after getting annoyed by it's inaccuracy, I've devised one myself using python (numpy + matplotlib + sklearn).*

## Downloads
Check releases for precompiled app or build it yourself from source.\
You need .Net Framework v4.8.1 to compile it.

## Suggestions
Feel free to give suggestions or report any bugs via [issues](https://github.com/artv15/RBWR-Thingy/issues).

## Disclaimer
i'm not responsible if I get your reactor explodet, sowwy
