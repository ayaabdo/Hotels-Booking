import React from 'react';
import { Route, Redirect, RouteProps } from 'react-router-dom';

// fake Auth
const isAuth = false;

export interface PrivateRouteProps extends RouteProps {
  component: any,
  name?: string
}

export interface GenericRouteProps extends PrivateRouteProps {
  isPrivate: boolean
}

const GenericRoute: React.FC<GenericRouteProps> = ({ isPrivate, name, ...rest }) => {
  return (
    isPrivate ? <PrivateRouter {...rest} /> : <Route {...rest} />
  );
};

const PrivateRouter: React.FC<PrivateRouteProps | any> =
  ({ component: Component, ...rest }) => ( <Route
    {...rest}
    render={(props) =>
      isAuth
      ? <Component {...props} />
      : <Redirect to={{ pathname: '/login', state: { from: props.location } }}/>
    }
  /> );
export default GenericRoute;