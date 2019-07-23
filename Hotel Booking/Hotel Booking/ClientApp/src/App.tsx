import React from 'react';
import { BrowserRouter as Router, Switch } from 'react-router-dom';
import Navbar from './components/Navbar';
import 'semantic-ui-css/semantic.min.css'
import GenericRoute from './components/GenericRoute';

import { routes } from './utils/routing/routes';

const App: React.FC = () => {
  return (
    <Router>
      <Navbar/>
      <Switch>
        {routes.map((route, idx) => <GenericRoute key={idx} {...route}/>)}
      </Switch>
    </Router>
  );
};


export default App;
