import React, { useState, FC } from 'react';
import { Container, Dropdown, Menu, MenuItemProps } from 'semantic-ui-react';
import { Link, NavLink, NavLinkProps } from 'react-router-dom';

const Navbar: FC = (props) => {
  console.log(props);

  const [activeItem, setActiveItem] = useState('home');

  const handleItemClick = (e: any, item: MenuItemProps) => setActiveItem(item.name || 'home');

  const handleURLMatching = (match: NavLinkProps, location: NavLinkProps) => {
    console.log(match, location)
    
  };


  return (
    <div className={'app-navbar'}>
      <Menu color={'red'} pointing secondary size='huge'>
        <Container>
          <Menu.Item header className={'logo-header'}>Travelshop.com</Menu.Item>
          <Menu.Menu position='right'>
            <Menu.Item
              name='home'
              active={activeItem === 'home'}
              onClick={handleItemClick}
              as={NavLink} to="/"
              isActive={handleURLMatching}
            />
            <Menu.Item
              name='about'
              active={activeItem === 'about'}
              onClick={handleItemClick}
              as={Link} to="/about"
            />

            <Dropdown item text='UK(E)' icon='angle down'>
              <Dropdown.Menu>
                <Dropdown.Item as={Link} to="/about" text='About'/>
                <Dropdown.Item as={Link} to={'/'} text='Home'/>
              </Dropdown.Menu>
            </Dropdown>

            <Dropdown item text='English' icon='angle down'>
              <Dropdown.Menu>
                <Dropdown.Item as={Link} to="/about" text='English'/>
                <Dropdown.Item as={Link} to={'/'} text='Arabic'/>
              </Dropdown.Menu>
            </Dropdown>
            <Menu.Item
              name='SignIn'
              active={activeItem === 'SignIn'}
              onClick={handleItemClick}
            />
          </Menu.Menu>
        </Container>

      </Menu>

    </div>
  );
};

export default Navbar;