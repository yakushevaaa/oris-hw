import React from "react";
import types from "../data/types";
import capacity from "../data/capacity";

const Filter = ({
  activeTypes,
  setActiveTypes,
  activeCapacities,
  setActiveCapacities,
  price,
  setPrice,
}) => {
  // Обработчик клика по чекбоксам типа
  const handleTypeClick = (label) => {
    setActiveTypes(
      (prevActive) =>
        prevActive.includes(label)
          ? prevActive.filter((item) => item !== label) // Удалить, если уже активен
          : [...prevActive, label] // Добавить, если не активен
    );
  };

  // Обработчик клика по чекбоксам вместимости
  const handleCapacityClick = (label) => {
    setActiveCapacities(
      (prevActive) =>
        prevActive.includes(label)
          ? prevActive.filter((item) => item !== label) // Удалить, если уже активен
          : [...prevActive, label] // Добавить, если не активен
    );
  };

  // Обработчик изменения ползунка
  const handlePriceChange = (event) => {
    const value = event.target.value;
    setPrice(value);
  };

  return (
    <div className="filter">
      {/* Тип */}
      <h6 className="type">T Y P E</h6>
      <ul className="filter-type">
        {types.map(({ label, count }) => (
          <li key={label}>
            <span
              className={`checkbox ${
                activeTypes.includes(label) ? "active" : ""
              }`}
              onClick={() => handleTypeClick(label)}
            ></span>
            <span className="label">
              {label} <span className="count">({count})</span>
            </span>
          </li>
        ))}
      </ul>

      {/* Вместимость */}
      <h6 className="capacity">C A P A C I T Y</h6>
      <ul className="capacity-of-car">
        {capacity.map(({ label, count }) => (
          <li key={label}>
            <span
              className={`checkbox ${
                activeCapacities.includes(label) ? "active" : ""
              }`}
              onClick={() => handleCapacityClick(label)}
            ></span>
            <span className="label">
              {label} <span className="count">({count})</span>
            </span>
          </li>
        ))}
      </ul>

      {/* Цена */}
      <h6 className="filter-price">P R I C E</h6>
      <div className="pricerange">
        <input
          type="range"
          id="price-slider"
          min="0.00"
          max="125.00"
          value={price}
          onChange={handlePriceChange}
          style={{
            background: `linear-gradient(to right, #007bff 0%, #007bff ${
              ((price - 0) / (125.0 - 0)) * 100.0
            }%, #e9ecef ${((price - 0) / (125.0 - 0)) * 100.0}%, #e9ecef 100%)`,
          }}
        />
        <p>
          Max. $<span id="price-value">{price}</span>
        </p>
      </div>
    </div>
  );
};

export default Filter;
