import React, { useState, useEffect } from "react";
import { motion } from "framer-motion";
import MovieItem from "./MovieItem";
import data from "../data/MOCK_DATA.json";

type Props = {};

const MovieList = (props: Props) => {
  const fake: string =
    "https://api.lorem.space/image/movie?w=150&amp;amp;amp;amp;h=220";

  //   console.log(data);
  const [data, setdata] = useState<[]>();

  const API_URL = "https://localhost:7031/api/movies";

  const getid = (e) => {
    console.log(e);
  };

  const fetchPosts = () => {
    const data = axios
      .get(API_URL)
      .then((resp) => {
        console.log(resp.data);
        setdata(resp.data);
      })
      .catch((err) => {
        // Handle Error Here
        console.error(err);
      });
  };

  useEffect(() => {
    fetchPosts();
  }, []);

  return (
    <motion.div
      initial={{ opacity: 0 }}
      whileInView={{ opacity: 1 }}
      transition={{ duration: 1.5 }}
      className=" flex relative flex-col text-center md:text-left
xl:flex:row max-w-[2000px] xl:px-10 min-h-screen justify-center xl:space-y-0 mx-auto items-center"
    >
      <h3 className="absolute top-50 uppercase tracking-[3px] text-gray-500 text-sm">
        Look this
      </h3>

      <div className="grid grid-cols-6 gap-5">
        {data.map((movie) => (
          <MovieItem
            url={movie.url}
            author={movie.author}
            title={movie.title}
          />
        ))}
      </div>
    </motion.div>
  );
};

export default MovieList;
