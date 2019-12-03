import React, { Component } from 'react';

export class CountryData extends Component {
    static displayName = CountryData.name;

    constructor(props) {
        super(props);
        this.state = { countries: [], loading: true };
    }

    componentDidMount() {
        this.getCountryData();
    }
    
    async getCountryData()
    {
        const data = await fetch('CountryData');
        this.setState({ countries: data, loading: false });
    }   

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : CountryData.renderCountriesTable(this.state.countries);

        return (
            <div>
                <h1 id="tabelLabel" >Country Codes Search</h1>
                <br /><h4>Please select a country ISO code (2 digits) and click "SUBMIT"</h4><br />
                <form className="form-group">
                    <label style={{marginRight: 1.5 + 'em'}} >
                        <b>ISO Code: </b>
                        <input maxlength="2" style={{ width: "50px" }} required type="text" name="name" />
                    </label><br/>
                    <input style={{marginTop: 2.5 + 'em'}} className="btn btn-primary" type="submit" value="SUBMIT" />
                </form><br />
                {contents}
            </div>
        );
    }

    static renderCountriesTable(countries) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                
                <thead>         
                <th>COLUMN NAME</th>
                <th>VALUE</th>
                </thead>
                <tbody>
                <tr>
                        {/* HERE NEEDS TO BE ADDED DATA-BINDING BETWEEN THE .NET-CORE CONTROLLER AND REACT, FINDING THE RIGHT SYNTAX TO DO THAT */}
                </tr>
                </tbody>
            </table>
        );
    }
    
    
}