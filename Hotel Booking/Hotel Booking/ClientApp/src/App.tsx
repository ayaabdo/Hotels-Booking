import React from 'react';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import Home from './pages/Home';
import About from './pages/About';
import Navbar from './components/Navbar';
import 'semantic-ui-css/semantic.min.css'

const App: React.FC = () => {
  return (
    <div className='App'>
      <Router>
        <Navbar/>
        <Route exact path={'/'} component={Home}/>
        <Route path={'/about'} component={About}/>
      </Router>
    </div>
  );
};

export default App;
