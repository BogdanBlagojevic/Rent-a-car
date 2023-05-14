import React from 'react';

export default function HeroSection({ setIsLoginModalOpened, setIsRegisterModalOpened }) {

    const showRegisterModal = () => {

        setIsRegisterModalOpened(true);
        setIsLoginModalOpened(false);
    }

    const showLoginModal = () => {

        setIsRegisterModalOpened(false);
        setIsLoginModalOpened(true);
    }

    return (
        <section className="home" id="home">
            <div className="text">
                <h1><span>Rent</span>   a Car</h1>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. <br /> Lorem ipsum dolor sit amet consectetur.</p>
                <div className="app-stores">
                    <button onClick={showRegisterModal}>Register</button>
                    <button onClick={showLoginModal}>Log in</button>
                </div>
            </div>
        </section >
    )
}
