import React, { Component, useRef, useState, useEffect } from 'react';

export class SurveyDefinition extends Component {
    static displayName = SurveyDefinition.name;

    constructor(props) {
        super(props);
        this.state = {
            definitions: [],
        };
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount() {
        this.getData();
    }

    render() {
        return (            
          this.SurveyFormDefinition(this.state.definitions)
        );
    }

    // Function to handle form submission
    handleSubmit = (event) => {
        event.preventDefault();

        const formData = new FormData(event.target);

        const options = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                surveyId: event.target.id,
                firstName: formData.get("firstName"),
                lastName: formData.get("lastName"),
                email: formData.get("email"),
                age: formData.get("age")
            })
        };

        // Make a POST request to the API with the formdata
        fetch('api/response/' + event.target.id, options);
        this.props.history.push('/');
    };

    async getData() {
        const someID = 1;
        const response =  await fetch('api/surveys/' + someID);
        const data =  await response.json();
        this.setState({ definitions: data });
    }

    SurveyFormDefinition = (form) => {
        return (
            <form id={form.id} onSubmit={this.handleSubmit} >
                <h1>{form.name}</h1>
                <p dangerouslySetInnerHTML={{ __html: form.description }} />
                <div class="input-group mb-3 w-25">
                    {form.properties &&
                        Object.keys(form.properties).map((property) => {
                            const prop = form.properties[property];
                            return (
                                <div key={property}>
                                    <label htmlFor={property}>{prop.label}</label>
                                    {prop.required && <span>*</span>}
                                    <input
                                        type={prop.type}
                                        id={property}
                                        name={property}
                                        required={prop.required}
                                        min={prop.minValue}
                                        max={prop.maxValue} //breaking the html page
                                        class="form-control"
                                    />
                                </div>
                            );
                        })}
                </div>
                <input type="submit" class="btn btn-primary" value="Submit" />
            </form>
        );
    }
}



