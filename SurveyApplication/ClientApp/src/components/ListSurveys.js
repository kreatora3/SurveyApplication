﻿import React, { Component } from 'react';
import { Link } from 'react-router-dom';


export class ListSurveys extends Component {
    static displayName = ListSurveys.name;

    constructor(props) {
        super(props);
        this.state = {
            surveys: [],
            surveysToExport: ""
        };
    }
   
    componentDidMount() {
        this.getData();
        this.getDataToExport();
       }

    render() {
        return (
            this.FormList(this.state.surveys)
        );
    };

    async getData() {
        const response = await fetch('api/surveys');
        const data = await response.json();
        this.setState({ surveys: data});
    }

    async getDataToExport() {
        const response = await fetch('api/response/12');
        const data = await response.text();
        this.setState({ surveysToExport: data });
    }


    handleClick = () => {
        const fileData = encodeURIComponent(this.state.surveysToExport);
        const link = document.createElement('a');
        link.setAttribute('href', 'data:text/csv;charset=utf-8,' + fileData);
        link.setAttribute('download', 'my-csv-file.csv');
        link.click();
    };

    FormList = (surveys) => {
        return (
            <table className='table table-striped' >
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Link</th>
                        <th>Button</th>
                    </tr>
                </thead>
                <tbody>
                    {surveys.map(survey => (
                        <tr key={survey.id}>
                            <td>{survey.name}</td>
                            <td><Link to="/surveydefinition">Survey details</Link></td>
                            <td>
                                <button onClick={this.handleClick}>Export</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        );
    };
}





