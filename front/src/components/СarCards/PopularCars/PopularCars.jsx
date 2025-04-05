import CarCard from "../CarCard/CarCard";
import React from "react";
import { useState, useEffect } from "react";

const PopularCars = ({ searchQuery }) => {
  console.log("Current Search Query:", searchQuery);

  const [cars, setCars] = useState([]);
  // const filteredCars = cars.filter(
  //   (car) =>
  //     searchQuery
  //       ? car.name.toLowerCase().includes(searchQuery.toLowerCase())
  //       : true // Если searchQuery пустой, возвращаем все машины
  // );

  useEffect(() => {
    fetch("https://localhost:7011/Cars/GetCars").then(async (response) => {
      const data = await response.json();
      setCars(data);
      console.log(data);
    });
  }, []);

  useEffect(() => {
    const fetchFilteredCars = async () => {
      try {
        // Создаем URL с query-параметрами
        const url = new URL("https://localhost:7011/Cars/GetFilteredCars");

        if (searchQuery) {
          url.searchParams.append("name", searchQuery);
        }

        const response = await fetch(url);

        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();
        setCars(data);
      } catch (error) {
        console.error("Error fetching cars:", error);
      }
    };

    fetchFilteredCars();
  }, [searchQuery]);

  return (
    <>
      <div className="text">
        <h4 className="highlited-gray">Popular cars</h4>
        <a href="/Category" className="view">
          View All
        </a>
      </div>
      <div className="popular-cars row">
        {cars.map((car) => (
          <div
            key={car.id}
            className="col-10 offset-1 col-lg-6 offset-lg-0 col-xl-3 car p-3"
          >
            <CarCard
              id={car.id}
              name={car.name}
              cathegory={car.category}
              img={car.img}
              liters={car.liters}
              transmission={car.transmission}
              spaces={car.spaces}
              price={car.price}
            />
          </div>
        ))}
      </div>
    </>
  );
};

export default PopularCars;
