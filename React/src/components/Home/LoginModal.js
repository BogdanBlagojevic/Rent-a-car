import React from 'react';
import { BiX } from "react-icons/bi";

export default function LoginModal({ isLoginModalOpened, setIsLoginModalOpened, setIsRegisterModalOpened }) {

    const showRegisterModal = (e) => {

        e.preventDefault();
        setIsRegisterModalOpened(true);
        setIsLoginModalOpened(false);
    }

    return (
        <div style={isLoginModalOpened ? { display: "flex" } : { display: "none" }} className="wrapper">
            <BiX onClick={() => { setIsLoginModalOpened(false) }} className="icon-close" />
            <div className="form-box login">
                <h2>Login</h2>
                <form action="#">
                    <div className="input-box">
                        <span className="icon"><i className='bx bxs-envelope'></i></span>
                        <input type="email" required />
                        <label>Email</label>
                    </div>
                    <div className="input-box">
                        <span className="icon"><i className='bx bxs-lock' ></i></span>
                        <input type="password" required />
                        <label>Password</label>
                    </div>
                    <button type="submit" className="btn">Login</button>
                    <div className="login-register">
                        <p> Don't have an account?
                            <a onClick={(e) => { showRegisterModal(e) }} href="#" className="register-link"> Register</a></p>
                    </div>
                </form>
            </div>
        </div>
    )
}
