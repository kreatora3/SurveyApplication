import React, { Component } from 'react';
import { Route, BrowserRouter, Switch } from 'react-router-dom';
import { ListSurveys } from './components/ListSurveys'
import { SurveyDefinition } from './components/SurveyDefinition'
import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <BrowserRouter>
                <Switch>
                    <Route exact path="/" component={ListSurveys} />
                    <Route exact path="/surveydefinition" component={SurveyDefinition} />
                </Switch>
            </BrowserRouter>
        );
    }
}