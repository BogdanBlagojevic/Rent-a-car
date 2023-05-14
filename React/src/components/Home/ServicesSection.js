import React from 'react';
import { Link } from 'react-router-dom';
import c1 from "../../images/c1.png";
import c2 from "../../images/c2.png";
import c3 from "../../images/c3.png";
import c4 from "../../images/c4.png";
import c5 from "../../images/c5.jpg";
import c6 from "../../images/c6.jpg";

export default function ServicesSection() {
    return (
        <section className="services" id="services">
            <div className="heading">
                <span>Best Services</span>
                <h1>Cars<br /> Top Rated Models</h1>
            </div>
            <div className="services-container">
                <div className="box">
                    <div className="box-img">
                        <img src={c1} alt="" />
                    </div>
                    <p>2020</p>
                    <h3>Mercedes-Benz-E-Class </h3>
                    <h4><span>City: </span>Novi Sad</h4>
                    <h2>Price | $120 <span>/Day</span></h2>
                    <Link to="/rent" className='btn'>RENT NOW</Link>
                </div>
                <div className="box">
                    <div className="box-img">
                        <img src={c2} alt="" />
                    </div>
                    <p>2018</p>
                    <h3>BMW X3</h3>
                    <h4><span>City: </span>Novi Sad</h4>
                    <h2>Price | $100 <span>/Day</span></h2>
                    <Link to="/rent" className='btn'>RENT NOW</Link>
                </div>
                <div className="box">
                    <div className="box-img">
                        <img src={c3} alt="" />
                    </div>
                    <p>2021</p>
                    <h3>Mercedes-Benz GLC 4x4 GPS</h3>
                    <h4><span>City: </span>Novi Sad</h4>
                    <h2>Price | $150 <span>/Day</span></h2>
                    <Link to="/rent" className='btn'>RENT NOW</Link>
                </div>
                <div className="box">
                    <div className="box-img">
                        <img src={c4} alt="" />
                    </div>
                    <p>2019</p>
                    <h3>Hyundai Elantra</h3>
                    <h4><span>City: </span>Novi Sad</h4>
                    <h2>Price | $90 <span>/Day</span></h2>
                    <Link to="/rent" className='btn'>RENT NOW</Link>
                </div>
                <div className="box">
                    <div className="box-img">
                        <img src={c5} alt="" />
                    </div>
                    <p>2020</p>
                    <h3>Peugeot 308</h3>
                    <h4><span>City: </span>Novi Sad</h4>
                    <h2>Price | $80 <span>/Day</span></h2>
                    <Link to="/rent" className='btn'>RENT NOW</Link>
                </div>
                <div className="box">
                    <div className="box-img">
                        <img src={c6} alt="" />
                    </div>
                    <p>2021</p>
                    <h3>Audi SQ5</h3>
                    <h4><span>City: </span>Novi Sad</h4>
                    <h2>Price | $140 <span>/Day</span></h2>
                    <Link to="/rent" className='btn'>RENT NOW</Link>
                </div>
            </div>
        </section>
    )
}
