import React from 'react';
import { HashLink } from 'react-router-hash-link';
import logo from "../images/LOGO.png";
import { BiMenu } from "react-icons/bi";
import { useState } from 'react';

export default function Header() {

    const [isNavVisible, setIsNavVisible] = useState(false);

    return (
        <header>
            <HashLink to="/#home" className="logo ">
                <img src={logo} alt="logo" />
            </HashLink>
            <BiMenu onClick={() => { setIsNavVisible(!isNavVisible) }} id="menu-icon" className='bx' />
            <ul style={isNavVisible ? { left: "0px" } : { left: "100%" }} className="navbar">
                <li><HashLink to="/#home">Home</HashLink></li>
                <li><HashLink to="/#rent">Rent</HashLink></li>
                <li><HashLink to="/#services">Services</HashLink></li>
                <li><HashLink to="/#about">About</HashLink></li>
            </ul>
        </header>
    )
}
