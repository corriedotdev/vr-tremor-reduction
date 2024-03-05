# "Tremor Reduction for Accessible Ray Based Interaction in VR"

<div align="center">

[![alt text](https://github.com/corriedotdev/VR-Research/raw/main/1-euro-filter/filter.PNG?raw=true)](https://github.com/corriedotdev/VR-Research/blob/main/1-euro-filter/filter.PNG?raw=true)


[Link to build](https://github.com/corriedotdev/vr-tremor-reduction/releases/tag/vr) | [Link to paper tbc]() 
</div>

This project was a significant piece of work I completed during my PhD. Please do reach out to me if you want to discuss the findings, I want this solution integrated on every VR HMD to improve user experience. 

This project (1-Euro Filter) is now open source, and this exact build was used for conducting user testing with a normalisation algorithm filtering out user noise at various ranges.
The scene is developed using URP and supports the filtering of transforms and quaternions.

This repo is to go alongside its paper counterpart which is published with the additon of the interaction zone graphics to contribute to an accessible VR framework.

* Download the ground ergonomic template 1-euro-filter/Assets/Textures/VR Ergonomic Safe Zone v2.png
* Scene 1 Contains simulated noise on a transform where values are outputted to a CSV document. Values are also filtered based on the arguments passed to the one euro filter algorithm. These are also outputted to the CSV document ready for visualisation. Current default values can be found at this link on an interactive [Tableau dashboard.](https://public.tableau.com/app/profile/corrie.green/viz/1EuroFilter/Sheet3)
* Scene 2 Contains the new accesible VR graphic scene with simple laser pointers and the environment for conducting user tests. Please do use this as a template for your future work! By introducing the filtered script we can toggle the filter on and off via the method demonstrated and support in reducing involuntary tremors that may become debilitating to some users when using a VR interface.

Filter was forked from by [Dario Mazzanti](https://www.iit.it/people/dario-mazzanti)
