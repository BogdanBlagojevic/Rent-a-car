import React from 'react';
import { FaFacebookF, FaInstagram, FaLinkedinIn, FaTwitter, FaYoutube } from "react-icons/fa";
import { Link } from 'react-router-dom';

export default function Footer() {
    return (
        <footer className="copyright">
            <p>&#169;2023 Copy Right Rent a Car</p>
            <div className="social">
                <div className="fbox">
                    <Link to="/">
                        <FaFacebookF className='bx' />
                    </Link>
                </div>
                <div className="fbox">
                    <Link to="/">
                        <FaInstagram className='bx' />
                    </Link>
                </div>
                <div className="fbox">
                    <Link to="/">
                        <FaYoutube className='bx' />
                    </Link>
                </div>
                <div className="fbox">
                    <Link to="/">
                        <FaLinkedinIn className='bx' />
                    </Link>
                </div>
                <div className="fbox">
                    <Link to="/">
                        <FaTwitter className='bx' />
                    </Link>
                </div>
            </div>
        </footer>
    )
}
