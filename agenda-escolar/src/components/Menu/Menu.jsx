import React, { useState } from 'react'
import './Menu.css'
// import Sidebar from '../Sidebar/Sidebar';
import CollapsedButton from '../CollapsedButton/CollapsedButton';

const Menu = () => {
    const [isOpen, setIsOpen] = useState(false);

    return (
         <div className='content'>
                <CollapsedButton isOpen={isOpen}  setIsOpen={setIsOpen}/> 
         </div>       
    )
}

export default Menu