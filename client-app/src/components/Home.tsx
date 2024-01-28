import { useState } from "react";
import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs";
import { Button } from "./ui/button";
import SearchBar from "./Home/SearchBar";
import { SearchResultList } from "./Home/SearchResultList";

const Home = () => {
  const [results, setResults] = useState([]);

  return (
    <>
      <Tabs
        defaultValue="dashboard"
        className="bg-background px-3 py-5 shadow-lg rounded-lg transition-all duration-300 delay-300"
      >
        <TabsList className="flex justify-start gap-3 lg:gap-12 lg:px-6 bg-background mb-10 border-b-[1px]">
          <TabsTrigger className=" lg:text-xl" value="dashboard">
            Dashboard
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="tasks">
            Tasks
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="pipeline">
            Pipeline
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="Goals">
            Goals
          </TabsTrigger>
        </TabsList>
        <section className="mx-auto w-fit transition-all duration-300 delay-300 lg:w-[885px]">
          <TabsContent
            value="dashboard"
            className="flex flex-col rounded-lg shadow-md p-4 border gap-5 w-full transition-all duration-300 delay-300"
          >
            <h2 className="text-xl text-primary-accent text-left">Search</h2>
            <div>
              <SearchBar setSearchResults={setResults} />
            </div>
            <div className="flex gap-6">
              <Button variant="outline" disabled>
                New Member Applications
              </Button>
              <Button variant="outline" disabled>
                New Prospect
              </Button>
            </div>
          </TabsContent>
          <SearchResultList results={results} />
        </section>
      </Tabs>
    </>
  );
};

export default Home;
