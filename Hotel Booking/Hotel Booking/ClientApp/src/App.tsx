import React from 'react';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';
import Home from './pages/Home';
import About from './pages/About';

const App: React.FC = () => {
  return (
    <div className='App'>
      <Router>
        <Route exact path={'/'} component={Home}/>
        <Route path={'/about'} component={About}/>
      </Router>

    </div>
  );
};

export default App;
