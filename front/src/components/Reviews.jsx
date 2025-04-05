import React, { useEffect, useState } from "react";
import ReviewCard from "./ReviewCard";

const Reviews = ({ id }) => {
  const [comments, setComments] = useState([]);
  useEffect(() => {
    // const path = `https://localhost:7011/api/Comments/GetCarComment?id=${id}`;
    fetch(`https://localhost:7011/api/Comments/GetCarComment?id=${id}`).then(
      async (response) => {
        const data = await response.json();
        setComments(data);
        console.log(comments);
      }
    );
  }, []);
  return (
    <div className="col-12 p-3">
      <div className="p-3 reviews">
        <h4 className="m-3 mb-4">
          Reviews <background-blue>13</background-blue>
        </h4>
        {comments.map((comment) => (
          <ReviewCard
            key={comment.id}
            name={comment.name}
            position={comment.position}
            text={comment.text}
            date={comment.date}
            img={comment.img}
          ></ReviewCard>
        ))}
        <div className="col-2 offset-5 d-flex align-items-center">
          <h4 className="highlited-gray">Show All</h4>
          <i className="fa-solid fa-arrow-down ml-2 highlited-gray"></i>
        </div>
      </div>
    </div>
  );
};

export default Reviews;
