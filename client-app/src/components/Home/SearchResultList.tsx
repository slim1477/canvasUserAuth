import { SearchResult } from "./SearchResult";

interface User {
  firstName: string;
  lastName: string;
  id: number;
  dob: string;
  email: string;
  address: string;
  phoneNumber: string;
}
export const SearchResultList = ({ results }: { results: User[] }) => {
  return (
    <div className="border shadow-lg transition-all duration-300 delay-300">
      {results.length > 0 &&
        results.map((member) => {
          const fullName = member.firstName + " " + member.lastName;
          return (
            <a key={member.id} href={`profile/${member.id}`}>
              <SearchResult
                email={member.email}
                address={member.address}
                memberName={fullName}
                dateOfBirth={member.dob}
              />
            </a>
          );
        })}
    </div>
  );
};
