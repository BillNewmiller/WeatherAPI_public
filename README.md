# WeatherAPI_public
This repo contains the four files needed to for a webforms VS project that works with a the WeatherLink API to download data from a Davis Vantage Pro 2 ISS.
To make the project work for your ISS, you need to modify the default.aspx.cs, using your api secret and api key.
You can see the application in operation at https://billnewmiller.com/iss/

You will need to add the Newsoft Json package form nuget to your project.

The SensorData.cs file is specific to my ISS, which has wind, barometer, temperature, and humidity sensors. If your ISS has different sensors, you will need to modify this file.
