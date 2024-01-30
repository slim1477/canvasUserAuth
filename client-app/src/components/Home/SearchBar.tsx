import { useState } from "react";
import { Input } from "../ui/input";

const SearchBar = ({
  setSearchResults,
}: {
  setSearchResults: (results: []) => void;
}) => {
  const API_URL = "http://localhost:5002/api/v1/members";
  const [searchInput, setSearchInput] = useState("");

  const fetchData = (value: string) => {
    fetch(API_URL)
      .then((response) => response.json())
      .then((data) => {
        const results = data.filter((user: { firstName: string }) => {
          return (
            value &&
            user &&
            user.firstName &&
            user.firstName.toLowerCase().includes(value.toLowerCase())
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
