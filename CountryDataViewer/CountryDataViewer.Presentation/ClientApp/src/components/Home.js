import React, { Component } from 'react';
import dependencyGraph from './Images/DependenciesGraph.png';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (

      <div>
        <h1>NOTES FOR TOM</h1><br/>
        <p>The current project has been created using .NET Core 3.0 (Back-end) and Create-React-App (Front-end)</p>
        
        <p>The ISO code's info is retrieved in the back-end from Restful API and converted/encapsulated in data-structure usable within the code. Below the description of the back-end architecture I developed for this project:</p>
        
        <ul>
            <li><strong>Presentation Layer: </strong>This is the point of contact where the controller interfaces with the front-end. It's worth mentioning this layer doesn't connect directly with the service layer, but it's linked with a decorator which offers a cache set to 5 minutes.</li>
            <li><strong>Data-Access Layer: </strong>In this layer is managed the connection with external resources applying the repository pattern. In our case connects to the Restful API (https://restcountries.eu/#sources) passing the code desired, retrieving the JSON and deserializing it to a C# object (Countries).</li>
            <li><strong>Unit Tests: </strong> The unit test project included a couple of tests to check if data is returned from the Restful API; in addition any codes/data can be added in the FakeData.cs to check much faster if specific codes exists and have data within.</li>

        </ul>

        <p>The following <code> Dependency-Diagram</code> shows how I structured the project in different layers (Separation of Concerns). Each of them can be expanded individually by different members of team without hampering each-other:</p><br/>
        <p align="center"><img src={dependencyGraph} width="70%" /></p><br/>
        <p>In the front-end when you click on the "CountryData" page button, I setup (for testing purposes) a call to the controller which retrieves data from the back-end but I actually need to find a way to bind it in order to be showed in the table</p>
      </div>
    );
  }
}