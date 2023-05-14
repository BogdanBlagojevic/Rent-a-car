import React from 'react';
import BMW from "../../images/BMW_330i_M_Sport_G20_2019_White_background_Blue_580476_9166x6865.jpg";

export default function AboutSection() {
    return (
        <section className="about" id="about">
            <div className="heading">
                <span>About Us</span>
                <h1>All you need to know about us</h1>
            </div>
            <div className="about-container">
                <div className="about-text">
                    <span>About Us</span>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Repudiandae recusandae temporibus labore ad tempore minus dolores omnis neque! Eum molestias labore quidem sapiente itaque earum voluptas ducimus inventore temporibus veniam! Sed hic ipsum explicabo!</p>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Nam modi atque officiis, sequi praesentium amet aliquid alias eveniet.</p>
                </div>
                <div className="about-img">
                    <img src={BMW} alt="" />
                </div>
            </div>
        </section>
    )
}
