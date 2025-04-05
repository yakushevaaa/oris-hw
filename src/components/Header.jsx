import React from 'react';

const Header = ({ searchQuery, setSearchQuery }) => {
    const handleInputChange = (e) => {
      const value = e.target.value;
      if (setSearchQuery) {
        setSearchQuery(value); // Обновляем состояние поиска
      }
    };
    return (
        <header class="site-header">
            <a href='/' class="title">MORENT </a>
            <div class="search-container">
            <input
                type="text"
                className="search-input"
                placeholder="Search something here"
                value={searchQuery}
                onChange={handleInputChange}
            />
            </div>
            <div class="Profile_And_Notification">
                <button class="like">
                    <img src="/src/assets/heart.png"/>
                </button>
                <button class="notification">
                    <div class="notif"></div>
                    <img src="/src/assets/notification.png"/>
                </button>
                <button class="settings">
                    <img src="/src/assets/setting-2.png"/>
                </button>
                <div class="profile">
                    <img src="/src/assets/profile.png" alt="profile" class="profile-image"/>
                </div>
            </div>
        </header>
    );
};

export default Header;