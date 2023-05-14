import React from 'react';
import { useState } from 'react';
import HeroSection from "./HeroSection";
import ServicesSection from "./ServicesSection";
import RentSection from "./RentSection";
import AboutSection from "./AboutSection";
import LoginModal from './LoginModal';
import RegisterModal from './RegisterModal';

export default function Home() {

    const [isLoginModalOpened, setIsLoginModalOpened] = useState(false);
    const [isRegisterModalOpened, setIsRegisterModalOpened] = useState(false);

    return (
        <>
            <HeroSection setIsLoginModalOpened={setIsLoginModalOpened} setIsRegisterModalOpened={setIsRegisterModalOpened} />
            <ServicesSection />
            <RentSection />
            <AboutSection />
            <LoginModal isLoginModalOpened={isLoginModalOpened} setIsLoginModalOpened={setIsLoginModalOpened} setIsRegisterModalOpened={setIsRegisterModalOpened} />
            <RegisterModal isRegisterModalOpened={isRegisterModalOpened} setIsRegisterModalOpened={setIsRegisterModalOpened} setIsLoginModalOpened={setIsLoginModalOpened} />
        </>
    )
}
