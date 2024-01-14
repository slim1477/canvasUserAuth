import { useState } from "react";
import { Input } from "@/components/ui/input";
import "./App.css";

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <h2>Member Profile</h2>
      <Input />
    </>
  );
}

export default App;
