import Home from '../../pages/Home';
import { GenericRouteProps } from '../../components/GenericRoute';
import About from '../../pages/About';
import NotFound_404 from '../../pages/404';

export const routes: GenericRouteProps[] = [
  {
    name: 'home',
    path: '/',
    component: Home,
    isPrivate: false,
    exact: true
  },
  {
    name: 'about',
    path: '/about',
    component: About,
    isPrivate: true,
    exact: false
  },
  {
    name: '404',
    path: '/404',
    component: NotFound_404,
    isPrivate: false,
    exact: false
  },
  {
    name: '404',
    path: '*',
    component: NotFound_404,
    isPrivate: false,
    exact: false
  }
];