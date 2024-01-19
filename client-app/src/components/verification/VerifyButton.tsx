import { useState } from "react";
import { Button } from "../ui/button";

import successIcon from "@/assets/Verification/success.png";
import failIcon from "@/assets/Verification/fail.png";

export const VerifyButton = () => {
  const [isVerified, setIsVerified] = useState(false);
  return (
    <>
      <Button
        className="h-full w-full border shadow-md bg-background rounded-2xl hover:bg-slate-50"
        onClick={() => setIsVerified((prev) => !prev)}
      >
        <div className="flex gap-2">
          <p className="text-lg text-black">
            {isVerified ? "Verified" : "Verify"}
          </p>

          {<img className="h-6" src={isVerified ? successIcon : failIcon} />}
        </div>
      </Button>
    </>
  );
};
