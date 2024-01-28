import { useState } from "react";
import { Input } from "../ui/input";

const SearchBar = ({
  setSearchResults,
}: {
  setSearchResults: (results: []) => void;
}) => {
  // const API_URL = "http://localhost:5002/apiv1/";
  const [searchInput, setSearchInput] = useState("");

  const fetchData = (value: string) => {
    fetch("https://jsonplaceholder.typicode.com/users")
      .then((response) => response.json())
      .then((data) => {
        const results = data.filter((user: { name: string }) => {
          return (
            value &&
            user &&
            user.name &&
            user.name.toLowerCase().includes(value.toLowerCase())
          );
        });
        setSearchResults(results);
      });
  };
  const handleNewChange = (value: string) => {
    setSearchInput(value);
    fetchData(value);
  };

  return (
    <div>
      <Input
        placeholder="Search for person or business"
        onChange={(e) => handleNewChange(e.target.value)}
        value={searchInput}
      />
    </div>
  );
};

export default SearchBar;
