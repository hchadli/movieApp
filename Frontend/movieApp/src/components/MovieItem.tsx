import React from "react";
import { motion } from "framer-motion";

type Props = {
  id?: number;
  directionLeft?: boolean;
  url?: string | undefined;
  title?: string;
  author?: string | "Abddel";

  onClick: (id) => {};
};

const MovieItem = ({ author, directionLeft, url, title, genre }: Props) => {
  const fake: string =
    "https://api.lorem.space/image/movie?w=150&amp;amp;amp;amp;h=220";
  return (
    <>
      <p>{title}</p>
      <p className="text-red-400">{author}</p>
      <div className="group relative flex cursor-pointer">
        <motion.img
          initial={{
            x: directionLeft ? -200 : 200,
            opacity: 0,
          }}
          transition={{ duration: 1 }}
          whileInView={{ opacity: 1, x: 0 }}
          src={url ? undefined : fake}
          alt=""
          className="rounded-md border border-gray-500 object-cover w-40 h-40 md:w-36 md:h-36 xl:w-40 xl:h-40
    filter group-hover:grayscale transition duration-300 ease-in-out"
        />
        <div
          className="absolute opacity-0 group-hover:opacity-80 transition duration-300 ease-in-out
        group-hover: bg-white w-40 h-40 md:w-36 md:h-36 xl:w-40 xl:h-40 rounded-md z-0"
        >
          {/* <div className="flex items-center justify-center h-full">
            <p className="text-3xl font-bold text-black opacity-100">{genre}</p>
          </div> */}
        </div>
      </div>
    </>
  );
};

export default MovieItem;
