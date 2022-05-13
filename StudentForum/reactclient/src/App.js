import React, { Component } from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { AskQuestion } from './components/AskQuestion';
import { Forum } from './components/Forum';
import { Question } from './components/Question';
import { Tags } from './components/Tags';
import { Tag } from './components/Tag';
import { NavMenu } from './components/NavMenu';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div>
        <NavMenu />
      </div>
    );
  }
}

/*
<Layout>
        <Route exact path='/' component={Forum} />
        <Route exact path='/Question' component={Question} />
        <Route exact path='/Tags' component={Tags} />
        <Route exact path='/AskQuestion' component={AskQuestion} />
        <Route exact path='/Tag' component={Tag} />
      </Layout>
*/
