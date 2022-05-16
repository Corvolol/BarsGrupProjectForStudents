import React, { Component } from 'react';
import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import { Layout } from './components/Layout';
import { AskQuestion } from './components/AskQuestion';
import { Forum } from './components/Forum';
import { Question } from './components/Question';
import { Tags } from './components/Tags';
import { Tag } from './components/Tag';
import { Teachers } from './components/Teachers';

export default function App() {
    return (
      <>
        <Teachers />
      </>
    );
  }

/*
<Router>
          <div>
            <Routes>
              <Layout>
                <Route exact path='/' element={<Forum />} />
                <Route exact path='/question' element={<Question />}  />
                <Route exact path='/tags' element={<Tags />}  />
                <Route exact path='/ask-question' element={<AskQuestion />}  />
                <Route exact path='/tag' element={<Tag />} />
                <Route exact path='/teachers' element={<Teachers />} />
              </Layout>
            </Routes>
          </div>
        </Router>
*/
