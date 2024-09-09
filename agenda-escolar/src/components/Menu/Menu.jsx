import React from 'react';
import './Menu.css';

const Menu = () => {
  return (
    <div className='content-menu'>
        <a href={"/home"}>
        <button className="menu-button">
        <div className="menu-line"></div>
        <div className="menu-line"></div>
        <div className="menu-line"></div>
        </button>
        </a>
    </div>
  );
};

export default Menu;
