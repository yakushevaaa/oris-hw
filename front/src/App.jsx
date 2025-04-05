import React, { useState } from "react";
import "./App.css";
import HomeRent from "./Pages/HomeRent.jsx";
import { Routes, Route } from "react-router-dom";
import Layout from "./layout/Layout";
import CategoryCar from "./Pages/CategoryCar.jsx";
import DetailCar from "./Pages/DetailCar";
import PayPage from "./Pages/PayPage.jsx";

function App() {
  const [searchQuery, setSearchQuery] = useState("");

  return (
    <div>
      <Routes>
        <Route
          path="/"
          element={
            <Layout searchQuery={searchQuery} setSearchQuery={setSearchQuery} />
          }
        >
          <Route index element={<HomeRent searchQuery={searchQuery} />} />
          <Route path="category" element={<CategoryCar />} />
          <Route path="/detail/:id" element={<DetailCar />} />
          <Route path="rent/:id" element={<PayPage />} />
        </Route>
      </Routes>
    </div>
  );
}

export default App;
