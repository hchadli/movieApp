import { useState } from "react";
import reactLogo from "./assets/react.svg";
import "./App.css";
import Header from "./components/Header";
import Movies from "./components/Movies";
import MovieList from "./components/MovieList";

function App() {
  return (
    <div className="bg-[rgb(36,36,36)] text-white h-screen snap-y snap-mandatory overflow-scroll z-0">
      <Header />

      <section>
        <Movies />
      </section>

      <section>
        <MovieList />
      </section>
    </div>
  );
}

export default App;
