import React from "react";
import { Link } from "react-router-dom";

const CarInfo = ({ car }) => {
  return (
    <div className="container-fluid">
      {/* Сетка Bootstrap */}
      <div className="row align-items-center">
        {/* Левая колонка */}
        <div className="col-md-6 mt-4">
          <div
            className="banner-content"
            style={{
              backgroundColor: "#3563E9",
              height: "360px",
              borderRadius: "10px",
            }}
          >
            <div className="p-4 text-white">
              <h2 className="fw-bold">
                Sports car with the best design and acceleration
              </h2>
              <p>
                Safety and comfort while driving a futuristic and elegant sports
                car
              </p>
            </div>
            {/* Изображение автомобиля */}
            <img src={car.img} alt="Current Car" className="car-image" />
          </div>

          {/* Миниатюры */}
          <div className="thumbnails d-flex gap-3 mt-3">
            <img
              src={car.img}
              alt="Nissan GT-R Side"
              className="rounded"
              style={{ width: "170px", height: "110px", objectFit: "cover" }}
            />
            <img
              src="/src/assets/View_2.png"
              alt="Nissan GT-R Interior"
              className="rounded"
              style={{ width: "170px", height: "130px", objectFit: "cover" }}
            />
            <img
              src="/src/assets/View_3.png"
              alt="Nissan GT-R Seats"
              className="rounded"
              style={{ width: "170px", height: "130px", objectFit: "cover" }}
            />
          </div>
        </div>

        {/* Правая колонка */}
        <div className="col-md-6">
          <div className="card rounded p-4">
            <h1 className="card-title fw-bold">{car.name}</h1>
            <div className="rating d-flex align-items-center gap-3 mb-5">
              <i className="fas fa-star text-warning"></i>
              <i className="fas fa-star text-warning"></i>
              <i className="fas fa-star text-warning"></i>
              <i className="fas fa-star text-warning"></i>
              <i className="fas fa-star-half-alt text-warning"></i>
              <span className="text-muted">440+ Reviewer</span>
            </div>
            <p className="card-text text-muted">{car.description}</p>

            {/* Характеристики */}
            <div className="row mt-4">
              <div className="col-3">
                <p style={{ color: "#90A3BF" }}>Type Car</p>
                <p style={{ color: "#90A3BF" }}>Steering</p>
              </div>
              <div className="col-3">
                <p>{car.category}</p>
                <p>{car.transmission}</p>
              </div>
              <div className="col-3">
                <p style={{ color: "#90A3BF" }}>Capacity</p>
                <p style={{ color: "#90A3BF" }}>Gasoline</p>
              </div>
              <div className="col-3">
                <p>{car.spaces} People</p>
                <p>{car.liters}L</p>
              </div>
            </div>

            {/* Цена и кнопка */}
            <div className="d-flex justify-content-between align-items-center mt-5">
              <h2 className="fw-bold">${car.price}.00 / days</h2>
              <Link to={`/rent/${car.id}`} className="btn btn-primary btn-lg">
                Rent Now
              </Link>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default CarInfo;
