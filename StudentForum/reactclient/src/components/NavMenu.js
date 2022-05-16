import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink, Button, Input } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export default function NavMenu() {
  return (
    <header>
      <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
        <Container>
          <NavbarBrand tag={Link} to="/">Students Forum</NavbarBrand>
          <ul className="navbar-nav flex-grow">
            <NavItem>
              <Input placeholder="Search" />
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="text-dark" to="/">Forum</NavLink>
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="text-dark" to="/tags">Tags</NavLink>
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="text-dark" to="/teachers">Teachers</NavLink>
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="text-dark" to="/askquestion"><Button>Ask question</Button></NavLink>
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="text-dark" to="/registration"><Button color="primary">Sign in</Button></NavLink>
            </NavItem>
          </ul>
        </Container>
      </Navbar>
    </header>
  );
}
