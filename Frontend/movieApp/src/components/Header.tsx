import React from "react";
import { motion } from "framer-motion";

type Props = {};

const Header = (props: Props) => {
  return (
    <header className="sticky top-0 p-5 flex items-start justify-evenly max-w-7xl mx-auto z-20 xl:items-center">
      <motion.div
        initial={{
          x: -500,
          opacity: 0,
          scale: 0.5,
        }}
        animate={{
          x: 0,
          opacity: 1,
          scale: 1,
        }}
        transition={{ duration: 2 }}
        className="flex flex-row items-center"
      >
        Movies App
      </motion.div>

      <motion.div
        initial={{
          x: 500,
          opacity: 0,
          scale: 0.5,
        }}
        animate={{
          x: 0,
          opacity: 1,
          scale: 1,
        }}
        transition={{
          duration: 1.5,
        }}
        className="flex flex-row items-center text-gray-300"
      >
        <p className=" italic underline uppercase hidden md:inline-flex text-sm text-gray-400">
          Get Yours movies
        </p>
      </motion.div>
    </header>
  );
};

export default Header;
