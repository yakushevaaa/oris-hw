import React, { useState } from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';
import { Outlet } from 'react-router-dom';

const Layout = () => {
  const [searchQuery, setSearchQuery] = useState('');

  return (
    <div>
      <Header searchQuery={searchQuery} setSearchQuery={setSearchQuery} />
      <main>
        <Outlet context={{ searchQuery }} />
      </main>
      <Footer />
    </div>
  );
};

export default Layout;