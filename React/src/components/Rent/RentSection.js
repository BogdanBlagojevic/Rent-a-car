import React from 'react';
import { BiCar, BiCalendar, BiDollarCircle, BiMapPin, BiUser, BiMap, BiCalendarAlt, BiMoney, BiBuildingHouse, BiHomeAlt } from "react-icons/bi";

export default function RentSection() {
    return (
        <section>
            <div className="rent-wrapper">
                <h2>Rent a Car</h2>
                <form action="" method="post">
                    <div className="carImg">
                        <img src="img/c1.png" alt="" />
                    </div>
                    <h4>Car information</h4>
                    <div className="input_group">
                        <div className="input_box">
                            <input type="text" placeholder="Car Brand" required className="name" readOnly />
                            <BiCar className='bx' />
                        </div>
                        <div className="input_box">
                            <input type="text" placeholder="Car Model" required className="name" readOnly />
                            <BiCar className='bx' />
                        </div>
                    </div>
                    <div className="input_group">
                        <div className="input_box">
                            <input type="text" placeholder="Year" required className="name" readOnly />
                            <BiCalendar className='bx' />
                        </div>
                    </div>
                    <div className="input_group">
                        <div className="input_box">
                            <input type="text" placeholder="Price/Day" required className="name" readOnly />
                            <BiDollarCircle className='bx' />
                        </div>
                    </div>
                    <div className="input_group">
                        <div className="input_box">
                            <input type="text" placeholder="Type of gearbox" required className="name" readOnly />
                            <BiMapPin className='bx' />
                        </div>
                    </div>
                    <h4>Rent Details</h4>
                    <div className="input_group">
                        <div className="input_box">
                            <input type="text" name="" className="name" placeholder="User" required readOnly />
                            <BiUser className='bx' />
                        </div>
                    </div>
                    <div class="input_group">
                        <div class="input_box">
                            <input type="text" name="" class="name" placeholder="Country" required readOnly />
                            <BiMap className='bx' />
                        </div>
                    </div>
                    <div class="input_group">
                        <div class="input_box">
                            <input type="text" name="" class="name" placeholder="City" required readOnly />
                            <BiBuildingHouse className='bx' />
                        </div>
                    </div>
                    <div class="input_group">
                        <div class="input_box">
                            <input type="text" name="" class="name" placeholder="Address" required readOnly />
                            <BiHomeAlt className='bx' />
                        </div>
                    </div>
                    <h6>Pick up date/ Date of return</h6>
                    <div className="input_group">
                        <div className="input_box">
                            <div className="input_box">
                                <input type="date" required className="name" />
                                <BiCalendar className='bx' />
                            </div>
                        </div>
                        <div className="input_box">
                            <input type="date" required className="name" />
                            <BiCalendarAlt className='bx' />
                        </div>
                    </div>
                    <div className="input_box">
                        <input type="number" placeholder="Total price" required className="name" readOnly />
                        <BiMoney className="bx" />
                    </div>
                    <div className="input_group">
                        <div className="input_box">
                            <button type="submit">Rent Now</button>
                        </div>
                    </div>
                </form>
            </div>
        </section>
    )
}
