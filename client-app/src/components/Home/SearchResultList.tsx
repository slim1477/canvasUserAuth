import { SearchResult } from "./SearchResult";

interface User {
  firstName: string;
  lastName: string;
  id: number;
  username: string;
  email: string;
  address: string;
  phoneNumber: string;
}
export const SearchResultList = ({ results }: { results: User[] }) => {
  console.log(results);
  return (
    <div className="border shadow-lg transition-all duration-300 delay-300">
      {results.length > 0 &&
        results.map((member) => {
          const fullName = member.firstName + " " + member.lastName;
          return (
            <a href="profile/1">
              <SearchResult
                key={member.id}
                email={member.email}
                address={member.address}
                memberName={fullName}
                phone={member.phoneNumber}
              />
            </a>
          );
        })}
    </div>
  );
};
