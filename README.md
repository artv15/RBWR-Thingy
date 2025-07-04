# RBWR Thingy
A multitool for [Realistic Boiling Water Reactor Simulator](https://www.roblox.com/games/11765852158) game on Roblox

## Features
### MWe to APR conversion
Can convert MWe demand and plant usage to a more or less approximate APR target.

> [!WARNING]
> MWe to APR formula is now no longer matching up for unit 2 (as of 1.7.X)\
> Actual APR needed is now HIGHER than the calculator displays, it seems that there was a minor change in u2's APR to steam flow change or something along those lines.\
> I will get to fixing it at some point (preferably once I'll stop 'Eat Sleep Deepwoken Repeat' trend of mine), preferably using turbine flow as an X in most formulas instead of generator load.\
> *Be patient in the meanwhile pwease.*

> [!NOTE]
> Keep in mind that MWe to APR conversion is not 100% perfect, and there are a couple reasons why the resulting APR may be wrong:
> - Steam Pressure is not at 7.1 MPa
> - At leat one preheater is broken/disabled (using this calculator is a way to check them btw)
> - You have not updated plant usage
> - Steam sealing pressure is not at 0.25 bar (applies only to unit 2)
> 
> Other than that, the formula is pretty precise (≈1 MWe difference) if you are using automatic formula selection.

Will also show an approximate feedwater flow, which should be treated as a **rough approximation** (±30 kg/s).
Useful when you are making rapid adjustments and want to just forget about MCC.

### Auxilary stats
Approx turbine inlet, condenser flow (for u1), steam sealing (for u2) and oil cooling (for u2) are also calculated.\
To cheese condenser in unit 2, set recirculation to 100%, one SJAE to 100%, Sniffer valve to 60% and then adjust sniffer as needed.\
*Trust me, you better cheese the condenser in unit 2 and not run it normally.*

### Pump repairs on high outflow
Allows to calculate whether you can run without a pump without changing your load.\
Pretty precise I would say, at least it worked for unit 1 when I was testing it on a private server.\

I assume that pump shutoff is instant (like in unit 1). In unit 2, these repairs may actually be easier, since pump lag is benefitial for once.
### Repairs flagger
Useful if you get disconnected from the game from time to time, or just don't like in-game clipboard.

## Credits
- [This guide](https://docs.google.com/document/d/1Irwh4lIR1y15hKauZ3XupzsZ79sPYgwSfMnnWt8aulc/edit) by Avalakaba (@kopa_tel_oflain) for the MCC formula (RPV capacity is slightly wrong in this one, it should be 7500 kg/m, not 10000 kg/m)
- [This website](https://nxrvi.github.io/rbwrmultitoolweb/) by [Nxrvi](https://github.com/Nxrvi) for the previous Gen Load to APR and APR to Feedwater flow formula.

## Downloads
Check releases for precompiled app or build it yourself from source.\
You need .Net Framework v4.8.1 to compile it.

## Extra
Feel free to give suggestions or report any bugs via [issues](https://github.com/artv15/RBWR-Thingy/issues).
> [!CAUTION]
> i'm not responsible if I get your reactor explodet, sowwy :3
