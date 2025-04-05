import React from "react";
import { format } from "date-fns";
const ReviewCard = ({ name, position, text, date, img }) => {
    const formattedDate = format(new Date((date)), "dd-MM-yyyy");
  return (
    <div className="review row">
      <div className="review-img col-1 p-0">
        <img src={img} className="reviewer-img" alt="lol" />
      </div>
      <div className="col-11 row p-0">
        <div className="col-10 p-0">
          <h5 className="reviewer-name">{name}</h5>
          <h6 className="reviewer-post">{position}</h6>
        </div>
        <div className="col-2 p-0 data-stars">
          <p>{formattedDate}</p>
          <i className="fas fa-star"></i>
          <i className="fas fa-star"></i>
          <i className="fas fa-star"></i>
          <i className="fas fa-star"></i>
          <i className="fa-regular fa-star"></i>
        </div>
        <p className="mt-3 review-text">{text}</p>
      </div>
    </div>
  );
};

export default ReviewCard;
