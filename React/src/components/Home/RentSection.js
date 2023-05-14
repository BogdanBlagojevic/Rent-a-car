import React from 'react';
import { BiCar, BiCalendarCheck, BiMap } from "react-icons/bi";

export default function RentSection() {
    return (
        <section className="rent" id="rent">
            <div className="heading">
                <span>How To Rent</span>
                <h1>Rent with 3 Easy Steps</h1>
            </div>
            <div className="rent-container">
                <div className="box">
                    <BiCar className='bx' />
                    <h2>choose a car</h2>
                    <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Molestiae, repellendus? In beatae quas iure temporibus.</p>
                </div>
                <div className="box">
                    <BiCalendarCheck className='bx' />
                    <h2>Pick-Up Date</h2>
                    <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Molestiae, repellendus? In beatae quas iure temporibus.</p>
                </div>
                <div className="box">
                    <BiMap className='bx' />
                    <h2>choose a location</h2>
                    <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Molestiae, repellendus? In beatae quas iure temporibus.</p>
                </div>
            </div>
        </section>
    )
}
