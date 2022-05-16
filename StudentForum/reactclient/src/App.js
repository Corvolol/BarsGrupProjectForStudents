import React from 'react';
import { Route, Routes, Link } from 'react-router-dom';
import Login from './pages/Login';
import Registrarion from './pages/Registrarion';
import Forum from './pages/Forum'
import AskQuestion from './pages/AskQuestion'
import Teachers from './pages/Teachers';
import Tags from './pages/Tags'
import Teacher from './pages/Teacher';
import Questions from './pages/Questions';
import Question from './pages/Question';
import NavMenu from './components/NavMenu';
export default function App() {
  return (
    <dev>
      <NavMenu />
      <Routes>
        <Route path='/askquestion' element={<AskQuestion />} />
        <Route path='/login' element={<Login />} />
        <Route path='/registration' element={<Registrarion />} />
        <Route path='/tags' element={<Tags />} />
        <Route path='/teachers' element={<Teachers />} />
        <Route path='/teacger/{id}' element={<Teacher />} />
        <Route path='/question/{id}' element={<Question />} />
        <Route path='/questions' element={<Questions />} />
        <Route path='/' element={<Forum />} />
      </Routes>
    </dev>
  );
} 