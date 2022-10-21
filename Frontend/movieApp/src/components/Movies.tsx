import React from "react";
import { Cursor, useTypewriter } from "react-simple-typewriter";

type Props = {};

const Movies = (props: Props) => {
  const [text, count] = useTypewriter({
    words: ["Do You like movies ?", "Oh Boi check out our movies =>"],
    loop: true,
    delaySpeed: 2000,
  });
  return (
    <div className="h-screen flex flex-col space-y-8 justify-center text-center overflow-hidden">
      <h1 className="text-3xl lg:text-6xl font-semibold px-10 ">
        <span className="mr-3">{text}</span>
        <Cursor cursorColor="#F7AB0A" />
      </h1>
    </div>
  );
};

export default Movies;
