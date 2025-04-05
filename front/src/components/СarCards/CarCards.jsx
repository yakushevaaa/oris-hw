import PopularCars from "./PopularCars/PopularCars";
import RecommendationCars from "./RecommendationCars/RecommendationCars";
import { useOutletContext } from 'react-router-dom';

const CarCards = () => {
  const { searchQuery } = useOutletContext();

  return (
    <>
      <section className="cars-cards">
        <PopularCars searchQuery={searchQuery} />
        <RecommendationCars searchQuery={searchQuery}/>
      </section>
    </>
  );
};

export default CarCards;