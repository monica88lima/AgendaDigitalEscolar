import React from 'react'
import './Header.css'
import Menu from '../Menu/Menu'

const Header = ({ imgHeader, altHeader, textHeader }) => {
  return (
    <div className='content'>
            <Menu/>
             <img className='img' src="/images/tela-incial.png" alt={altHeader} />
    </div>
  )
}

export default Header