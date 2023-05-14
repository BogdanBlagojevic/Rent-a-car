import { Routes, Route } from "react-router-dom";
import Footer from "./components/Footer";
import Header from "./components/Header";
import Home from "./components/Home";
import Rent from "./components/Rent";

function App() {
  return (
    <>
      <Header />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/rent" element={<Rent />} />
      </Routes>
      <Footer />
    </>
  );
}

export default App;
