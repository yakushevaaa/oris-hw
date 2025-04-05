import React, { useState, useEffect } from "react";
import Filter from "../components/Filter";
import CategoryCarCards from "../components/СarCards/CategoryCarCards";
import { useLocation, useNavigate, useOutletContext } from "react-router-dom";
import CarInfo from "../components/DescriptionForCar";
import Reviews from "../components/Reviews";
import { useParams } from "react-router-dom";

const CarDetail = () => {
  const location = useLocation();
  const navigate = useNavigate();
  const { searchQuery } = useOutletContext();

  const [car, setCar] = useState();

  const { id } = useParams();
  const carId = parseInt(id, 10);

  useEffect(() => {
    fetch(`https://localhost:7011/Cars/GetCarById/${id}`).then(
      async (response) => {
        const data = await response.json();
        setCar(data);
        console.log(data);
      }
    );
  }, []);

  // Парсим query-параметры из URL
  const queryParams = new URLSearchParams(location.search);

  // Инициализация состояний из URL
  const [activeTypes, setActiveTypes] = useState(() =>
    queryParams.get("types") ? queryParams.get("types").split(",") : []
  );
  const [activeCapacities, setActiveCapacities] = useState(() =>
    queryParams.get("capacities")
      ? queryParams.get("capacities").split(",")
      : []
  );
  const [price, setPrice] = useState(() =>
    queryParams.get("price") ? parseFloat(queryParams.get("price")) : 100
  );

  // Функция для обновления URL
  const updateURL = () => {
    const params = new URLSearchParams();

    if (activeTypes.length > 0) {
      params.set("types", activeTypes.join(","));
    } else {
      params.delete("types");
    }

    if (activeCapacities.length > 0) {
      params.set("capacities", activeCapacities.join(","));
    } else {
      params.delete("capacities");
    }

    if (price !== 100) {
      params.set("price", price);
    } else {
      params.delete("price");
    }

    if (searchQuery) {
      params.set("query", searchQuery);
    } else {
      params.delete("query");
    }

    navigate({ search: params.toString() });
  };

  useEffect(() => {
    updateURL();
  }, [activeTypes, activeCapacities, price, searchQuery]);

  if (!car) {
    return <div>Car not found</div>;
  }

  return (
    <div className="AllCars">
      <Filter
        activeTypes={activeTypes}
        setActiveTypes={setActiveTypes}
        activeCapacities={activeCapacities}
        setActiveCapacities={setActiveCapacities}
        price={price}
        setPrice={setPrice}
      />
      <div className="blocks">
        <CarInfo car={car} />
        <Reviews id={carId} />
        <CategoryCarCards
          searchQuery={searchQuery}
          activeTypes={activeTypes}
          activeCapacities={activeCapacities}
          price={price}
        />
      </div>
    </div>
  );
};

export default CarDetail;
