import React from 'react';
import { BiX } from "react-icons/bi";

export default function RegisterModal({ isRegisterModalOpened, setIsRegisterModalOpened, setIsLoginModalOpened }) {

    const showLoginModal = (e) => {

        e.preventDefault();
        setIsRegisterModalOpened(false);
        setIsLoginModalOpened(true);
    }

    return (
        <div style={isRegisterModalOpened ? { display: "flex" } : { display: "none" }} className='wrapper'>
            <BiX onClick={() => { setIsRegisterModalOpened(false) }} className="icon-close" />
            <div className="form-box register">
                <h2>Registration</h2>
                <form action="#">
                    <div className="input-box">
                        <input id="user" type="text" required />
                        <label>Username</label>
                    </div>
                    <div class="input-box">
                        <input id="user" type="text" required />
                        <label>Name</label>
                    </div>
                    <div class="input-box">
                        <input id="user" type="text" required />
                        <label>Surname</label>
                    </div>
                    <div className="input-box">
                        <input type="email" required />
                        <label>Email</label>
                    </div>
                    <div className="input-box">
                        <input type="password" required />
                        <label>Password</label>
                    </div>
                    <button type="submit" className="btnR">Register</button>
                    <div className="login-register">
                        <p>Already have an account?
                            <a onClick={(e) => { showLoginModal(e) }} href="#" className="login-link"> Login</a></p>
                    </div>
                </form>
            </div>
        </div>
    )
}
