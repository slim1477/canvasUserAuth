import { SearchResult } from "./SearchResult";

interface User {
  name: string;
  id: number;
  username: string;
  email: string;
  address: {};
  phone: string;
}
export const SearchResultList = ({ results }: { results: User[] }) => {
  return (
    <div className="border shadow-lg transition-all duration-300 delay-300">
      {results.length > 0 &&
        results.map((member) => {
          return (
            <SearchResult
              key={member.email}
              email={member.email}
              memberName={member.name}
              phone={member.phone}
            />
          );
        })}
    </div>
  );
};
