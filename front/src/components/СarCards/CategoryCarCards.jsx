import React from "react";
import CarCard from "./CarCard/CarCard";
import { useState, useEffect } from "react";

const CategoryCarCards = ({
  searchQuery,
  activeTypes,
  activeCapacities,
  price,
}) => {
  const [cars, setCars] = useState([]);

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

        // Добавляем параметры фильтрации
        if (activeTypes.length > 0) {
          url.searchParams.append("category", activeTypes.join(","));
        }

        if (activeCapacities.length > 0) {
          const capacities = activeCapacities.map((c) =>
            c.replace(" Person", "")
          );
          url.searchParams.append("spaces", capacities.join(","));
        }

        if (price < 125) {
          url.searchParams.append("price", price);
        }

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
  }, [searchQuery, activeTypes, activeCapacities, price]);

  // // Фильтрация данных
  // const filteredCars = cars.filter((car) => {
  //   // Фильтр поиска
  //   const matchesSearch = searchQuery
  //     ? car.name.toLowerCase().includes(searchQuery.toLowerCase())
  //     : true;

  //   // Фильтр типов (если выбраны типы)
  //   const matchesType =
  //     activeTypes.length > 0
  //       ? activeTypes.some((type) => type === car.category)
  //       : true;

  //   // Фильтр вместимости (если выбраны вместимости)
  //   const matchesCapacity =
  //     activeCapacities.length > 0
  //       ? activeCapacities.some(
  //           (capacity) => capacity === `${car.spaces} Person`
  //         )
  //       : true;

  //   // Фильтр цены
  //   const matchesPrice = car.price <= price;

  //   return matchesSearch && matchesType && matchesCapacity && matchesPrice;
  // });

  return (
    <>
      <div className="cars-row">
        {cars.map((car) => (
          <div
            className="col-10 offset-1 col-md-4 offset-md-0 p-3"
            key={car.id}
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
      <div className="row">
        <a className="abutton col-2 offset-5 my-4">Show more cars</a>
        <p className="highlited-gray col-1 offset-4 align-items-center d-flex justify-content-end">
          {cars.length}
        </p>
      </div>
    </>
  );
};

export default CategoryCarCards;
